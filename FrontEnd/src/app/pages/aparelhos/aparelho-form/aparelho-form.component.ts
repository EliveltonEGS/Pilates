import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-aparelho-form',
  templateUrl: './aparelho-form.component.html',
  styleUrls: ['./aparelho-form.component.css']
})
export class AparelhoFormComponent implements OnInit {

  pageTitle: string;

  constructor() { }

  ngOnInit(): void {
    this.pageTitle = 'Cadastro de Novos Aparelhos';
  }

}
