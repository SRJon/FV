import axios from 'axios';
import { AuthenticationService } from './app/Modules/login/Services/Authentication.service';

export const AxiosConfig = () => {
  axios.defaults.baseURL = 'https://localhost:5001';
  axios.defaults.headers.common['Authorization'] =
    'Bearer ' + localStorage.getItem('token');
  let authToken = new AuthenticationService();
  axios.interceptors.response.use(
    (response) => {
      return response;
    },
    (error) => {
      if (error.response.status === 401) {
        authToken;
        // window.location.reload();
        console.log(authToken.getToken());
      }
      return Promise.reject(error);
    }
  );
};
