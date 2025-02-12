import { Component } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { StudentService } from '../../services/student.service';

@Component({
  selector: 'app-student-details',
  templateUrl: './student-details.component.html',
  styleUrl: './student-details.component.css',
})
export class StudentDetailsComponent {
  id: number = 0;
  student: any;
  constructor(
    activatedRoute: ActivatedRoute,
    private studentServices: StudentService,
    private router: Router
  ) {
    this.id = activatedRoute.snapshot.params['id'];
  }
  ngOnInit() {
    this.studentServices.getById(this.id).subscribe({
      next: (data) => {
        this.student = data;
      },
      error: () => {
        this.router.navigateByUrl('NotFound');
      },
    });
  }
}
