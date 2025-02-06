import { Component, EventEmitter, Input, Output } from '@angular/core';
import { Student } from '../model/student';
import { FormsModule } from '@angular/forms';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-register',
  imports: [FormsModule, CommonModule],
  templateUrl: './register.component.html',
  styleUrl: './register.component.css',
})
export class RegisterComponent {
  age: string = '';
  name: string = '';

  @Input()
  studentLength = 0;
  @Output()
  onAddNewStudent = new EventEmitter();

  addNewUser() {
    if (+this.age > 20 && +this.age < 40 && this.name.length > 3) {
      let newStudent: Student = {
        id: this.studentLength,
        name: this.name,
        age: +this.age,
      };
      this.onAddNewStudent.emit(newStudent);
    }
  }
}
