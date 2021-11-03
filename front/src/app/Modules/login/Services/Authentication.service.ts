import { Injectable } from '@angular/core';
import axios from 'axios';

@Injectable({
  providedIn: 'root',
})
export class AuthenticationService {
  public async login(user: string, password: string) {
    let payload = {
      name: user,
      password,
    };
    await axios
      .post('https://localhost:5001/login', payload)
      .then((result) => {
        let token = result.data.token;
        this.setTokenToHeader(token);
      })
      .catch((e) => {
        console.log(e);
      });
    console.log(user, password);
  }

  setTokenToHeader(token: string) {
    axios.defaults.headers.common = {
      'X-Requested-With': 'XMLHttpRequest',

      'X-CSRFToken': 'example-of-custom-header',

      Authorization: `Bearer ${token}`,
    };
  }

  teste() {
    axios
      .get('https://localhost:5001/logout')
      .then(console.log)
      .catch(console.log);
  }
}
