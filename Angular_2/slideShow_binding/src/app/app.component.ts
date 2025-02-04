import { Component } from '@angular/core';
import { BindingComponent } from './components/binding/binding.component';
import { SlideShowComponent } from './components/slide-show/slide-show.component';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrl: './app.component.css',
  imports: [BindingComponent, SlideShowComponent],
})
export class AppComponent {
  title = 'slideShow_binding';
}
