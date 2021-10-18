import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';



@Injectable({
  providedIn: 'root'
})
export class UserServiceService {

   ServiceEndPointR: any ='http://localhost:7001/Taazaa/User/create';
   ServiceEndPointL: any ='http://localhost:7001/Taazaa/User/check';

  constructor(private httpClient:HttpClient)
  {

  }

  CreateAccount(reg:any)  //:Observable<any>
  {// If a Fucnction return type is observable it means to access the data from this fumtion 
    //or to give the data to function we have to subscribe.

    return this.httpClient.post(this.ServiceEndPointR,reg);
  }

  LoginAccount(login:any)  //:Observable<any>
  {// If a Fucnction return type is observable it means to access the data from this fumtion 
    //or to give the data to function we have to subscribe.

    return this.httpClient.post(this.ServiceEndPointL,login);
  }
  loggedIn()
  {
  return sessionStorage.getItem('UserEmail');
  }
}
