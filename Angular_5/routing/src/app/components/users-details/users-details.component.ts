import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-users-details',
  imports: [CommonModule],
  templateUrl: './users-details.component.html',
  styles: ``,
})
export class UsersDetailsComponent {
  id: number = 0;
  constructor(activatedRoute: ActivatedRoute) {
    this.id = activatedRoute.snapshot.params['id'];
  }
}
