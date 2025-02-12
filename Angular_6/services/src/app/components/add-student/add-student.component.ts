import { Component } from '@angular/core';
import { StudentService } from '../../services/student.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-add-student',
  imports: [],
  templateUrl: './add-student.component.html',
  styleUrl: './add-student.component.css',
})
export class AddStudentComponent {
  showMessage = false;
  student: any;
  constructor(
    private studentServices: StudentService,
    private router: Router
  ) {}
  add(name: string, phone: string, email: string) {
    if (name && phone && email) {
      this.studentServices.add({ name, phone, email }).subscribe({
        next: (data) => {
          this.student = data;
          this.router.navigateByUrl('student/' + this.student.id);
        },
      });
    } else this.showMessage = true;
  }
}
