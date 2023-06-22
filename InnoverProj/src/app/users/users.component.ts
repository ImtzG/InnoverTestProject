import { Component, Inject, OnInit } from '@angular/core';
import { User } from 'src/dto/user';
import { UserServiceService } from 'src/services/user-service.service';

@Component({
  selector: 'app-users',
  templateUrl: './users.component.html',
  styleUrls: ['./users.component.scss']
})
export class UsersComponent implements OnInit{
    public studentList: User[] = [];
    
    constructor(private studentService: UserServiceService){}

    ngOnInit(){
        this.studentService.getStudentList()
          .subscribe((response:any) => this.studentList = response);

          console.log(this.studentList);
    }
}
