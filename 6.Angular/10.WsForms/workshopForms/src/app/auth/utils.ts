import { AbstractControl, ValidationErrors, ValidatorFn } from "@angular/forms";

export function emailValidator(control: AbstractControl): ValidationErrors | null {
    const value = control.value;

    if (!/.{6,}@gmail\.(bg|com)/.test(value)){
        return{
            email: true,
        }
    }
}

// export function passwordMatch(passwordFormControl: AbstractControl) {
//     return (rePasswordFormControl: AbstractControl) => {
//         if (passwordFormControl !== rePasswordFormControl) {
//             return {
//                 passwordMatch: true
//             }
//         }
//         return null;
//     }
// }

export function rePasswordValidatorFactory(targetControl:AbstractControl): ValidatorFn {
    return function rePasswordValidator(control:AbstractControl):  ValidationErrors | null{
        const areTheSame = targetControl.value === control.value;
        return areTheSame ? null: { rePasswordValidator: true };
    };
}