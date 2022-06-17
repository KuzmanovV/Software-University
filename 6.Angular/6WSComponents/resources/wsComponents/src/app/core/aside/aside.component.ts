import { Component, Input } from '@angular/core';
import { IPost } from 'src/app/shared/interfaces';

@Component({
  selector: 'app-aside',
  templateUrl: './aside.component.html',
  styleUrls: ['./aside.component.css']
})
export class AsideComponent<T> {

  @Input() title!: string;
  @Input() items: IPost[] | undefined;
  
  constructor() { }
}
