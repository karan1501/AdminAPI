import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-directive-test',
  templateUrl: './directive-test.component.html',
  styleUrls: ['./directive-test.component.css']
})
export class DirectiveTestComponent implements OnInit {

  public condition = false;
  public color = 'blue';

  constructor() {

  }

  ngOnInit() {
  }

}
