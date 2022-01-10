export interface ILoginValidation {
  isValid: boolean;
  message: string;
  causeBy: string;
}
export class Convert {
    public static toILoginValidation(json: string): ILoginValidation[] {
        return JSON.parse(json);
    }

    public static iLoginValidationToJson(value: ILoginValidation[]): string {
        return JSON.stringify(value);
    }
}
