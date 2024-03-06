import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { BehaviorSubject } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class BaseService {
  jatekosokSub = new BehaviorSubject(null)
  url= "https://localhost:5000/api/"

  constructor(private http:HttpClient) {
    this.loadJatekos()
   }

  loadJatekos(){
    this.http.get(this.url+"Jatekos").subscribe(
      (res:any)=> this.jatekosokSub.next(res)
    )
  }

  getJatekos(){
    return this.jatekosokSub
  }
}
