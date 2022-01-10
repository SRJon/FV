import { Injectable } from '@angular/core';
import axios from 'axios';
import { IUser } from 'src/app/Domain/Models/IUser';

@Injectable({
    providedIn: 'root',
})
export class AuthenticationService {
    public async login(user: string, password: string) {
        const payload = {
            name: user,
            password,
        };
        return await axios
            .post('/login', payload)
            .then((result) => {
                const token = result.data.token;
                this.setTokenToHeader(token);

                localStorage.setItem('token', token);
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

    checkToken() {
        const token = this.getToken();
        if (token) {
            this.setTokenToHeader(token);
            return true;
        }
        return false;
    }

    getToken() {
        return localStorage.getItem('token');
    }
    removeToken() {
        localStorage.removeItem('token');
    }

    static setGlogalUser(user: any) {
    // @ts-ignore: Unreachable code error
        window._5653435435435435435354354345845843584346845846466446_244_u_s_e_r =
      user;
    }
    static async getGlobalUser(): Promise<IUser> {
        let response: any;

        return await new Promise((r) => {
            const interval = setInterval(() => {
                response =
          // @ts-ignore: Unreachable code error
          window._5653435435435435435354354345845843584346845846466446_244_u_s_e_r;
                if (response) {
                    r(response);
                    clearInterval(interval);
                }
            }, 10);
        });
    }
}
