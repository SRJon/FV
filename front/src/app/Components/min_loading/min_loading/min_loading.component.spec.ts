/* tslint:disable:no-unused-variable */
import { async, ComponentFixture, TestBed } from '@angular/core/testing';
import { By } from '@angular/platform-browser';
import { DebugElement } from '@angular/core';

import { Min_loadingComponent } from './min_loading.component';

describe('Min_loadingComponent', () => {
    let component: Min_loadingComponent;
    let fixture: ComponentFixture<Min_loadingComponent>;

    beforeEach(async(() => {
        TestBed.configureTestingModule({
            declarations: [Min_loadingComponent],
        }).compileComponents();
    }));

    beforeEach(() => {
        fixture = TestBed.createComponent(Min_loadingComponent);
        component = fixture.componentInstance;
        fixture.detectChanges();
    });

    it('should create', () => {
        expect(component).toBeTruthy();
    });
});
