import { Component } from '@angular/core';
import { RegisterComponent } from './components/register/register.component';
import { Student } from './model/student';
import { TableComponent } from './components/table/table.component';

@Component({
  selector: 'app-root',
  imports: [RegisterComponent, TableComponent],
  templateUrl: './app.component.html',
  styleUrl: './app.component.css',
})
export class AppComponent {
  title = 'FormValidation';
  student: Student = {
    name: '',
    age: 0,
    id: null,
  };
  onRegister(newStudent: Student) {
    this.student = {
      name: newStudent.name,
      age: newStudent.age,
      id: null,
    };
  }
}
