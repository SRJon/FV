import axios from 'axios';
import { AuthenticationService } from './app/Modules/login/Services/Authentication.service';
import { Settings } from './Settings';

export const AxiosConfig = (l = (isLoading: boolean) => {}, ctx: any) => {
  let settings = Settings.getInstance();

  if (settings.isProduction) {
    axios.defaults.baseURL = 'http://10.200.200.6:5000';
  } else {
    axios.defaults.baseURL = 'http://localhost:5000';
  }

  let load = l.bind(ctx);
  axios.defaults.headers.common['Authorization'] =
    'Bearer ' + localStorage.getItem('token');

  let authToken = new AuthenticationService();

  axios.interceptors.request.use(
    (request) => {
      load(true);

      return request;
    },
    (error) => {
      load(false);
      return Promise.reject(error);
    }
  );

  axios.interceptors.response.use(
    (response) => {
      load(false);
      return response;
    },
    (error) => {
      load(false);
      if (error.response.status === 401) {
        authToken.removeToken();
        // window.location.href = '/login';
        let listUrl = window.location.href.split('/');
        if (listUrl[listUrl.length - 1] !== 'login') {
          window.location.href = '/login';
        }
      }
      return Promise.reject(error);
    }
  );
};
