/* tslint:disable:no-unused-variable */
import { async, ComponentFixture, TestBed } from '@angular/core/testing';
import { By } from '@angular/platform-browser';
import { DebugElement } from '@angular/core';

import { MainSidebarContainerComponent } from './MainSidebarContainer.component';

describe('MainSidebarContainerComponent', () => {
    let component: MainSidebarContainerComponent;
    let fixture: ComponentFixture<MainSidebarContainerComponent>;

    beforeEach(async(() => {
        TestBed.configureTestingModule({
            declarations: [MainSidebarContainerComponent],
        }).compileComponents();
    }));

    beforeEach(() => {
        fixture = TestBed.createComponent(MainSidebarContainerComponent);
        component = fixture.componentInstance;
        fixture.detectChanges();
    });

    it('should create', () => {
        expect(component).toBeTruthy();
    });
});
