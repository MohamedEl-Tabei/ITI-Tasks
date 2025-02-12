import { Directive, ElementRef, HostListener } from '@angular/core';

@Directive({
  selector: '[appCard]',
})
export class CardDirective {
  constructor(private elRef: ElementRef) {}
  @HostListener('mouseover') onMouseOver() {
    this.elRef.nativeElement.style.boxShadow = '0px 0px 10px 0px lightgray';
    this.elRef.nativeElement.style.transform = 'scale(1.1)';
  }
  @HostListener('mouseleave') onMouseLeave() {
    this.elRef.nativeElement.style.boxShadow = 'none';
    this.elRef.nativeElement.style.transform = 'scale(1)';
  }
}
