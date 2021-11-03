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
    return await axios
      .post('/login', payload)
      .then((result) => {
        let token = result.data.token;
        this.setTokenToHeader(token);
      })
      .catch((e) => {
        throw e;
      });
  }

  setTokenToHeader(token: string) {
    axios.defaults.headers.common = {
      'X-Requested-With': 'XMLHttpRequest',

      'X-CSRFToken': 'example-of-custom-header',

      Authorization: `Bearer ${token}`,
    };
  }

  teste() {
    axios.get('/logout').then(console.log).catch(console.log);
  }
}
