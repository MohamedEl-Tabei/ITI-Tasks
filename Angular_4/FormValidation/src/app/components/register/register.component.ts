import { Component, EventEmitter, Output } from '@angular/core';
import {
  FormControl,
  FormGroup,
  ReactiveFormsModule,
  Validators,
} from '@angular/forms';
import { Student } from '../../model/student';

@Component({
  selector: 'app-register',
  imports: [ReactiveFormsModule],
  templateUrl: './register.component.html',
  styleUrl: './register.component.css',
})
export class RegisterComponent {
  form = new FormGroup({
    name: new FormControl(null, [Validators.minLength(3)]),
    age: new FormControl(null, [Validators.min(20), Validators.max(50)]),
  });
  get isInValidName() {
    return this.form.controls.name.invalid;
  }
  get isInValidAge() {
    return this.form.controls.age.invalid;
  }
  @Output()
  register = new EventEmitter();

  onAddStudent() {
    if (this.form.valid) {
      let newStudent: Student = {
        name: this.form.controls.name.value,
        age: this.form.controls.age.value,
        id: null,
      };

      this.register.emit(newStudent);
    }
  }
}
