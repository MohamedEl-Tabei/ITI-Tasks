import { Component } from '@angular/core';
import { StudentService } from '../../services/student.service';
import { StudentComponent } from '../student/student.component';

@Component({
  selector: 'app-students',
  imports: [StudentComponent],
  providers: [StudentService],
  templateUrl: './students.component.html',
})
export class StudentsComponent {
  students: any;
  connected: boolean = true;
  constructor(private studentService: StudentService) {}
  ngOnInit() {
    this.studentService.getAll().subscribe({
      next: (data) => {
        this.students = data;
      },
      error: () => {
        this.connected = false;
      },
    });
  }
}
