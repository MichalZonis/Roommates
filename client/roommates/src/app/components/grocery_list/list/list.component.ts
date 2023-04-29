import { Component, OnInit } from '@angular/core';
import { FormControl } from '@angular/forms';

@Component({
  selector: 'app-list',
  templateUrl: './list.component.html',
  styleUrls: ['./list.component.scss']
})
export class ListComponent implements OnInit {

  list: string[] = []
  newItem = new FormControl('')

  constructor() { }

  ngOnInit(): void {
  }

  addItem(item: string | null) {
    if (item != null) this.list.push(item);
    this.newItem.reset();
  }

}
