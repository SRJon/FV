export interface IResponse<T> {
  success: boolean;
  statusCode: number;
  message: null;
  totalPages: number;
  page: number;
  data: T;
}
