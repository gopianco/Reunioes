import { Component, OnInit } from '@angular/core';
import { SalaService } from '../services/sala.service';
import { Sala } from '../model/sala';

@Component({
  selector: 'app-sala',
  templateUrl: './sala.component.html',
  styleUrls: ['./sala.component.css']
})
export class SalaComponent implements OnInit {
  sala: Sala;
  constructor(private salaServico: SalaService) { }

  ngOnInit() {
  }

  public cadastrar(){
    this.salaServico.cadastrar(this.sala)
      .subscribe(
        salaJson => {
          console.log(salaJson);
        },
        e => {
          console.log(e.error);
        }
      );
  }

}
