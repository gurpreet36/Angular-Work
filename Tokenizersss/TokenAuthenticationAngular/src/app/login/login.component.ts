import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { UserServiceService } from '../Service/user-service.service';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent 
{
  thisdata:any;

  LoginUserData=
  {
  email:'',
  password:''
}

  constructor(private userService:UserServiceService,private router:Router) 
  { 

  }

  LoginUser():void
  {
    //console.log(this.LoginUserData);
    
    this.userService.LoginAccount(this.LoginUserData).subscribe(response=>{
      this.thisdata=response;
      console.log(this.thisdata);
      sessionStorage.setItem('Token',this.thisdata.token);   //  Local storage

      (this.router.navigate(['/Home']));
    },err=>{
      console.log(err);
    })
    
  }
}
