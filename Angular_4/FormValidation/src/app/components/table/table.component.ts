import { Component, Input, OnChanges, SimpleChanges } from '@angular/core';
import { Student } from '../../model/student';

@Component({
  selector: 'app-table',
  imports: [],
  templateUrl: './table.component.html',
  styles: ``,
})
export class TableComponent implements OnChanges {
  count = 0;
  ngOnChanges(changes: SimpleChanges): void {
    if (!changes['student'].firstChange) {
      changes['student'].currentValue.id = this.students.length + 1;
      this.students.push(changes['student'].currentValue);
      console.log(changes['student'].currentValue);
    }
  }
  students: Student[] = [];
  @Input({ required: true })
  student: Student = { name: null, age: null, id: null };
}
