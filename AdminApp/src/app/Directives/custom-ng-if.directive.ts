import { Directive, ViewContainerRef, Input, TemplateRef, ElementRef, OnInit, HostListener } from '@angular/core';

@Directive({
  selector: '[appCustomNgIf]'
})
export class CustomNgIfDirective implements OnInit {

   @Input() color: string;
  // @Input() appCustomNgIf: boolean;

  constructor(private templateRef: ElementRef, private viewContainer: ViewContainerRef) {

  }

  ngOnInit() {
      // alert('color :: ' + this.color);
    // alert('appCustomNgIf :: ' + this.appCustomNgIf);
  }

  @HostListener('mouseenter') onMouseEnter() {
    this.highlight(this.color || 'red');
  }

  @HostListener('mouseleave') onMouseOver() {
    this.highlight('red');
  }

  private highlight(color: string) {
    this.templateRef.nativeElement.style.background = color;
  }

  // @Input() set appCustomNgIf(condition: boolean) {
  //   if (condition) {
  //     this.viewContainer.createEmbeddedView(this.templateRef);
  //   } else {
  //     this.viewContainer.clear();
  //   }
  // }

}
