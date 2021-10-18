import { Component} from '@angular/core';
import { UserServiceService } from '../Service/user-service.service';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent {

  Book:any=[];

  constructor(private userService:UserServiceService) 
  { 
    this.userService.GetBookDetails().subscribe(response=>{
      this.Book=response;
      console.log(this.Book);
      
    },err=>{
      console.log(err);
    });

  }

  // ngOninit()
  // {
  //   this.userService.GetBookDetails().subscribe(response=>{
  //     this.Book=response;
  //     console.log(this.Book);
      
  //   },err=>{
  //     console.log(err);
  //   });
  // }

}
