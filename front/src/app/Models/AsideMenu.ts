export class AsideMenu {
  open: boolean = false;

  constructor() {
    this.open = false;
  }

  setValue(v: boolean) {
    // alert(v);
    this.open = v;
  }
}
