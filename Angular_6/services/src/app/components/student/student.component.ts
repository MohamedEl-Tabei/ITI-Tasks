import { Component, Input } from '@angular/core';
import { RouterModule } from '@angular/router';
import { CardDirective } from '../../directives/card.directive';

@Component({
  selector: 'app-student',
  imports: [RouterModule, CardDirective],
  templateUrl: './student.component.html',
  styleUrl: './student.component.css',
})
export class StudentComponent {
  @Input({ required: true })
  data: { name: string; phone: string; email: string; id: number } = {
    name: '',
    phone: '',
    email: '',
    id: 0,
  };
}
