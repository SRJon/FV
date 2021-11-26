import { FormBuilder, Validators, FormGroup, FormControl} from '@angular/forms';
import { AlertsService } from 'src/app/Repository/Alerts/alerts.service';
import { ScreensService } from 'src/app/Modules/seguranca/Services/screens.service';
import { Component, EventEmitter, OnInit, Output } from '@angular/core';
import * as Entities from './../../Entities/';


@Component({
  selector: 'app-login-menu',
  templateUrl: './login-menu.component.html',
  styleUrls: ['./login-menu.component.scss'],
})
export class LoginMenuComponent implements OnInit {
  @Output() onSubmit = new EventEmitter<Entities.ILogin>();

  loginEntity: Entities.ILogin;
  isValid: boolean = false;
  serviceForm: FormGroup;

  constructor(private ScreensService: ScreensService,
              private AlertsService: AlertsService,
              private FormBuilder: FormBuilder
    ){
    this.serviceForm = this.FormBuilder.group({
      senha: ['', Validators.required]
    });

    
    this.loginEntity = {
      password: '',
      user: '',
    } as Entities.ILogin;
  }

  ngOnInit(): void {}

  Login() {
    this.onSubmit.emit(this.loginEntity);
  }


}
