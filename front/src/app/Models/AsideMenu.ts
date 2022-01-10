export class AsideMenu {
    open = false;

    constructor() {
        this.open = false;
    }

    setValue(v: boolean) {
    // alert(v);
        this.open = v;
    }
}
