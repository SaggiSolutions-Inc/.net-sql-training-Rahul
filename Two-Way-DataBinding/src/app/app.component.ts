import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'Two-Way-DataBinding';
  heading='Two Way Databinding';
  topic= "The changes maade in the source effects the target and  Vice versa.";

  uname=''
  t1:string=''
  n:number=0;
  gender:string=''
  terms:boolean=false;
  color:string='';
  languages:string[]=[];
}
