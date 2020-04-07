import { Component, OnInit } from '@angular/core';
import { Location } from '@angular/common';

import { Aparelho } from '../shared/aparelho.model';
import { AparelhoService } from '../shared/aparelho.service';

@Component({
  selector: 'app-aparelho-list',
  templateUrl: './aparelho-list.component.html',
  styleUrls: ['./aparelho-list.component.css']
})
export class AparelhoListComponent implements OnInit {

  aparelhos: Aparelho[] = [];

  constructor(
    private aparelhoService: AparelhoService,
    private location: Location) { }

  ngOnInit(): void {
    this.aparelhoService.getAll().subscribe(
      aparelhos => this.aparelhos = aparelhos,
      error => alert('Erro ao carregar a lista')
    );
  }

  deleteAparelho(aparelho: Aparelho) {
    const deleteConfirm = confirm('Deseja realmente excluir este aparelho?');

    if (deleteConfirm) {
      this.aparelhoService.delete(aparelho.aparelhoId).subscribe(
        () => this.aparelhos = this.aparelhos.filter(element => element != aparelho),
        () => alert('Erro ao tentar excluir')
      );
      this.load();
    }
  }

  /* métodos privados */
  load() {
    location.reload();
  }
}
