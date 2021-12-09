export class Settings {
  isProduction: boolean;
  static instance: Settings | null = null;

  constructor() {
    this.isProduction = true;
  }

  static getInstance() {
    let self = Settings.instance;
    if (!self) {
      self = new Settings();
    }
    return self;
  }
}
