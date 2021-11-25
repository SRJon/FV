export interface IResponse<T> {
  success: boolean;
  statusCode: number;
  message: string;
  totalPages: number;
  page: number;
  data: T;
}
