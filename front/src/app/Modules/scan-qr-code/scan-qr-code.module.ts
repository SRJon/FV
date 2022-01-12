import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { SegurancaRoutingModule } from './scan-qr-code-routing.module';
import { QRCComponent } from './Components/qrc/qrc.component';
import { NgQrScannerModule } from 'angular2-qrscanner';


@NgModule({
  declarations: [
    QRCComponent
  ],
  imports: [CommonModule, SegurancaRoutingModule, NgQrScannerModule],
})
export class ScanQrCodeModule {}

