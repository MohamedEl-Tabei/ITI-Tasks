import { Component } from '@angular/core';
import { Router, RouterModule } from '@angular/router';
import { FontAwesomeModule } from '@fortawesome/angular-fontawesome';
import { faHome, faPlus } from '@fortawesome/free-solid-svg-icons';
@Component({
  selector: 'app-nav-bar',
  imports: [RouterModule, FontAwesomeModule],
  templateUrl: './nav-bar.component.html',
  styleUrl: './nav-bar.component.css',
})
export class NavBarComponent {
  hiddenAll: boolean = false;
  hiddenAdd: boolean = false;
  homeIcon = faHome;
  plusIcon = faPlus;
  constructor(router: Router) {
    router.events.subscribe((e) => {
      let eventString = e.toString();
      if (eventString.includes('ActivationStart')) {
        this.hiddenAdd = eventString.includes('addStudent');
        this.hiddenAll = eventString.includes('**');
      }
    });
  }
}
