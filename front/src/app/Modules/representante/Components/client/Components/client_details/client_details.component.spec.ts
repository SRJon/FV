/* tslint:disable:no-unused-variable */
import { async, ComponentFixture, TestBed } from '@angular/core/testing';
import { By } from '@angular/platform-browser';
import { DebugElement } from '@angular/core';

import { Client_detailsComponent } from './client_details.component';

describe('Client_detailsComponent', () => {
    let component: Client_detailsComponent;
    let fixture: ComponentFixture<Client_detailsComponent>;

    beforeEach(async(() => {
        TestBed.configureTestingModule({
            declarations: [Client_detailsComponent],
        }).compileComponents();
    }));

    beforeEach(() => {
        fixture = TestBed.createComponent(Client_detailsComponent);
        component = fixture.componentInstance;
        fixture.detectChanges();
    });

    it('should create', () => {
        expect(component).toBeTruthy();
    });
});
