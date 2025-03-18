import { Component } from '@angular/core';

@Component({
  selector: 'app-ex04',
  templateUrl: './ex04.component.html',
  styleUrls: ['./ex04.component.css']
})
export class Ex04Component {
employees:any[]=[ {"id":1001,"ename":"Rahul","job":".NET Developer","Salary":250000},
  {"id":1002,"ename":"Tarun","job":"Business Analyst","Salary":350000}

];
}
