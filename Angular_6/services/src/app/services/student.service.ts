import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root',
})
export class StudentService {
  url = 'http://localhost:3000/students';
  constructor(public http: HttpClient) {}
  getAll() {
    return this.http.get(this.url);
  }
  add(body: any) {
    return this.http.post(this.url, { ...body });
  }
  getById(id: number) {
    return this.http.get(this.url + '/' + id);
  }
}
