import { Directive, ElementRef } from '@angular/core';

@Directive({
  selector: '[appCustom]'
})
export class CustomDirective {

  constructor(Element: ElementRef) {
    // console.log(Element);
    Element.nativeElement.style.background = 'red';
  }

}
