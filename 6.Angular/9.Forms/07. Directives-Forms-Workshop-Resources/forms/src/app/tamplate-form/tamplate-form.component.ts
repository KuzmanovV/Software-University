import { AfterViewInit, Component, OnInit, ViewChild } from '@angular/core';
import { NgForm } from '@angular/forms';

@Component({
  selector: 'app-tamplate-form',
  templateUrl: './tamplate-form.component.html',
  styleUrls: ['./tamplate-form.component.css']
})
export class TamplateFormComponent implements OnInit, AfterViewInit {

  @ViewChild('registrationForm') registrationForm!: NgForm;

  constructor() { }

  ngOnInit(): void {
  }

  ngAfterViewInit(): void {
    console.log(this.registrationForm.value);
    
  }

}
