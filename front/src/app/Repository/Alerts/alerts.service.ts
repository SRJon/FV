import { Injectable } from '@angular/core';
import Swal, { SweetAlertIcon, SweetAlertOptions } from 'sweetalert2';

@Injectable({
    providedIn: 'root',
})
export class AlertsService {
    constructor() {}

    public showAlert(
        title: string,
        icon: SweetAlertIcon = 'success',
        timer = 3000,
        options: SweetAlertOptions = {}
    ) {
        const Toast = Swal.mixin({
            toast: true,
            position: 'top-end',
            showConfirmButton: false,
            timer,
            timerProgressBar: true,

            didOpen: (toast) => {
                toast.addEventListener('mouseenter', Swal.stopTimer);
                toast.addEventListener('mouseleave', () =>
                    Swal.increaseTimer(Math.abs((Swal.getTimerLeft() || 0) - timer))
                );
                toast.addEventListener('mouseleave', Swal.resumeTimer);
            },
            ...options,
        });

        Toast.fire({
            icon: icon,
            title,
        });
    }
}
