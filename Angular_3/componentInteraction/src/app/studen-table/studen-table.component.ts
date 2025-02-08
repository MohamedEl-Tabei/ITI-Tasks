import { Component, Input } from '@angular/core';
import { Student } from '../model/student';

@Component({
  selector: 'app-studen-table',
  imports: [],
  templateUrl: './studen-table.component.html',
  styleUrl: './studen-table.component.css',
})
export class StudenTableComponent {
  @Input()
  students: Student[] = [];
}
