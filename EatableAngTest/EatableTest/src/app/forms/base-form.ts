import { FormGroup } from "@angular/forms";

export interface BaseForm{
    getNewForm(): FormGroup<any>;
    setForm(form: FormGroup<any>, object: object):void;
}