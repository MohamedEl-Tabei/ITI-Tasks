import { Component } from '@angular/core';
import { RegisterComponent } from './register/register.component';
import { Student } from './model/student';
import { StudenTableComponent } from './studen-table/studen-table.component';

@Component({
  selector: 'app-root',
  imports: [RegisterComponent, StudenTableComponent],
  templateUrl: './app.component.html',
  styleUrl: './app.component.css',
})
export class AppComponent {
  students: Student[] = [];
  title = 'componentInteraction';
  onAddNewStudent(newStudent: Student) {
    this.students.push(newStudent);
  }
}
