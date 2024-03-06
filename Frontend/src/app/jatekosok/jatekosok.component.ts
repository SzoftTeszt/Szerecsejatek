import { Component, OnDestroy } from '@angular/core';
import { BaseService } from '../base.service';
import { Subscription } from 'rxjs';

@Component({
  selector: 'app-jatekosok',
  templateUrl: './jatekosok.component.html',
  styleUrls: ['./jatekosok.component.css']
})
export class JatekosokComponent implements OnDestroy {
jatekosok:any;
feiratkozas= new Subscription();

constructor(private base:BaseService){
  this.feiratkozas=this.base.getJatekos().subscribe(
    (res)=>{
      this.jatekosok=res
      if (this.jatekosok)
        for (let i = 0; i < this.jatekosok.Length; i++) 
            this.jatekosok[i].tippek=false
    }
  )
}

ngOnDestroy(): void {
    if (this.feiratkozas) this.feiratkozas.unsubscribe()
}

}
