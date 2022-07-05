import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormControl, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { CreateUserDto, UserService } from 'src/app/core/user.service';
import { emailValidator, rePasswordValidatorFactory } from '../utils';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css']
})
export class RegisterComponent implements OnInit {

  passwordControl = new FormControl(null, [Validators.required, Validators.minLength(5)]);

  // get passwordsGroup(): FormGroup {
  //   return this.registerFormGroup.controls['passords'] as FormGroup;
  // }

  registerFormGroup: FormGroup = this.formBuilder.group({
    'username': new FormControl(null, [Validators.required, Validators.minLength(5)]),
    'email': new FormControl(null, [Validators.required, emailValidator]),
    // 'passwords': new FormGroup({
    'password': this.passwordControl,
    'rePassword': new FormControl(null, [rePasswordValidatorFactory(this.passwordControl)]),
    // }),
    'tel': new FormControl(''),
    'telRegion': new FormControl(''),
  })

  constructor(private formBuilder: FormBuilder, private userService: UserService, private router: Router) { }

  ngOnInit(): void {
  }

  shouldShowErrorForControl(controlName: string) {
    return this.registerFormGroup.controls[controlName].touched && this.registerFormGroup.controls[controlName].invalid
  }

  handleRegister(): void {
    const { username, email, password, tel, telRegion } = this.registerFormGroup.value;

    const body: CreateUserDto = {
      username: username,
      email: email,
      password: password,
    }

    if (tel) {
      body.tel = telRegion + tel;
    }

    this.userService.register$(body).subscribe(()=>{
      this.router.navigate(['/home']);
    })
  }
}
