import { Component } from '@angular/core';

@Component({
  selector: 'app-employees',
  templateUrl: './employees.component.html',
  styleUrls: ['./employees.component.css']
})
export class EmployeesComponent {
employees:any[] = [
  {"id":1001,"ename":"Rahul", "job":".NET Developer", "salary":250000},
  {"id":1002,"ename":"Tarun", "job":"Business Analyst", "salary":350000},
  {"id":1003,"ename":"Sheshu","job":"Business Analyst", "salary":250000}
];

e:any ={};
msg:string = '';
getbyid(id:number){
  //cloning 
  var e = JSON.stringify(this.employees.find(e=>e.id===id));
  this.e = JSON.parse(e);
  this.msg ='count of employees = ' +this.employees.length;
}
deletebyid(id:number){
  if (confirm("Are you sure to delete")){
    let index= this.employees.findIndex(e=>e.id==id);
    this.employees.splice(index,1)
    this.msg ='count of employees = ' +this.employees.length;    
  }
}
addemployee(){
  this.employees.push(this.e);
  this.e={};
  this.msg ='count of employees = ' +this.employees.length;
}
editEmployeeById(id:number){
  var index =  this.employees.findIndex(e=>e.id==id);
  this.employees[index]=this.e;
}
}
