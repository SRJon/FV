import {
  Component,
  OnInit,
  ViewChild,
  ViewEncapsulation,
  AfterViewInit,
} from '@angular/core';
import { QrScannerComponent } from 'angular2-qrscanner';

@Component({
  selector: 'app-qrc',
  templateUrl: './qrc.component.html',
  styleUrls: ['./qrc.component.scss'],
  encapsulation: ViewEncapsulation.None,
})
export class QRCComponent implements OnInit, AfterViewInit {
  devices: string[] = ['teste'];
  constructor() {}

  ngOnInit(): void {}

  @ViewChild(QrScannerComponent) qrScannerComponent:
    | QrScannerComponent
    | undefined;
  qrc() {
    if (this.qrScannerComponent) {
      this.qrScannerComponent.debug = true;

      this.qrScannerComponent.getMediaDevices().then((devices) => {
        alert(JSON.stringify(devices));
        console.log(devices);
        this.devices = devices.map(
          (e) => `${e.label} - ${e.kind} - ${e.deviceId}`
        );
        const videoDevices: MediaDeviceInfo[] = [];
        for (const device of devices) {
          if (device.kind.toString() === 'videoinput') {
            videoDevices.push(device);
          }
        }
        if (videoDevices.length > 0) {
          let choosenDev;
          for (const dev of videoDevices) {
            if (dev.label.includes('front')) {
              choosenDev = dev;
              break;
            }
          }
          if (choosenDev) {
            (this.qrScannerComponent as QrScannerComponent).chooseCamera.next(
              choosenDev
            );
          } else {
            (this.qrScannerComponent as QrScannerComponent).chooseCamera.next(
              videoDevices[0]
            );
          }
        }
      });

      this.qrScannerComponent.capturedQr.subscribe((result) => {
        console.log(result);
      });
    }
  }

  ngAfterViewInit(): void {
    this.qrc();
  }
}
