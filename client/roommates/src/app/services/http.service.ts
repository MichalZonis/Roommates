import { Injectable } from '@angular/core';
import { HttpClient } from "@angular/common/http"

@Injectable({
  providedIn: 'root'
})

@Injectable({
  providedIn: 'root'
})
export class HttpService {

  readonly ROOT_URL;

  constructor(private http: HttpClient) {
    this.ROOT_URL = "https://localhost:7221/api";
  }

  public get(uri: string, payload?: Object) {
    return this.http.get(`${this.ROOT_URL}/${uri}`, payload)
  }

  public post(uri: string, payload?: Object, options?: {}) {
    return this.http.post(`${this.ROOT_URL}/${uri}`, payload, options)
  }

  public put(uri: string, payload?: Object) {
    return this.http.put(`${this.ROOT_URL}/${uri}`, payload)
  }

  public delete(uri: string, payload?: Object) {
    return this.http.delete(`${this.ROOT_URL}/${uri}`, payload)
  }
}
