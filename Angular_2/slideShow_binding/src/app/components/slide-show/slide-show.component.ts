import { Component } from '@angular/core';
import { FontAwesomeModule } from '@fortawesome/angular-fontawesome';
import { faPause, faPlay } from '@fortawesome/free-solid-svg-icons';
@Component({
  selector: 'app-slide-show',
  imports: [FontAwesomeModule],
  templateUrl: './slide-show.component.html',
  styleUrl: './slide-show.component.css',
})
export class SlideShowComponent {
  imgNumber = 1;
  slideShowStatus = faPlay;
  interval?: ReturnType<typeof setInterval>;
  onPrev() {
    if (this.imgNumber > 1) this.imgNumber--;
  }
  onNext() {
    if (this.imgNumber < 5) this.imgNumber++;
  }
  onBtn() {
    if (this.slideShowStatus == faPause) {
      this.slideShowStatus = faPlay;
      clearInterval(this.interval);
    } else {
      this.slideShowStatus = faPause;
      this.interval = setInterval(() => {
        this.imgNumber = (this.imgNumber % 5) + 1;
      }, 1000);
    }
  }
}
