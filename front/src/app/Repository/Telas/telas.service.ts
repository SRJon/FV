import { Injectable } from '@angular/core';
import axios from 'axios';
import { ITela } from '../../Domain/Models/ITela';

@Injectable({
    providedIn: 'root',
})
export class TelasService {
    constructor() {}

    async getAll(perfilid: number): Promise<ITela[]> {
        const result = await axios.get('PerfilTela/getByProfile/' + perfilid);

        return result.data.data;
    }
}
