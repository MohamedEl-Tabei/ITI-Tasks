import { Routes } from '@angular/router';
import { StudentsComponent } from './components/students/students.component';
import { AddStudentComponent } from './components/add-student/add-student.component';
import { StudentDetailsComponent } from './components/student-details/student-details.component';
import { ErrorComponent } from './components/error/error.component';

export const routes: Routes = [
  { path: '', redirectTo: 'student', pathMatch: 'full' },
  { path: 'student', component: StudentsComponent },
  { path: 'student/:id', component: StudentDetailsComponent },
  { path: 'addStudent', component: AddStudentComponent },
  { path: '**', component: ErrorComponent },
];
