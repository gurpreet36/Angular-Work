import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
 import { HttpResponse ,HttpHeaders} from '@angular/common/http';


@Injectable({
  providedIn: 'root'
})
export class UserServiceService {

   ServiceEndPointR: any ='https://localhost:5001/api/Auth/register';
   ServiceEndPointL: any ='https://localhost:5001/api/Auth/login';
   ServiceEndPointBook:any='https://localhost:5001/api/Book';

  constructor(private httpClient:HttpClient)
  {

  }

  CreateAccount(reg:any)  //:Observable<any>
  {// If a Fucnction return type is observable it means to access the data from this fumtion 
    //or to give the data to function we have to subscribe.

    return this.httpClient.post(this.ServiceEndPointR,reg);
  }

  LoginAccount(lon:any)
  {
    return this.httpClient.post(this.ServiceEndPointL,lon);
  }

  loggedIn()
  {
  return sessionStorage.getItem('Token');
  }

  GetBookDetails()
  {
    var x:any;
    x=sessionStorage.getItem('Token');
    
    /* var headers_object = new HttpHeaders();
        headers_object.append('Content-Type', 'application/json');
        headers_object.append("Authorization", "Bearer " + x);

        const httpOptions = {
          headers: headers_object
        }; */

        var headers_object = new HttpHeaders({
          'Content-Type': 'application/json',
           'Authorization': "Bearer "+x
        });
    
            const httpOptions = {
              headers: headers_object
            };
    return this.httpClient.get(this.ServiceEndPointBook,httpOptions);
  }

}
