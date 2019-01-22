import { Component, OnInit, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-customers',
  templateUrl: './customers.component.html'
})
export class CustomersComponent implements OnInit {
  public customers: Customer[];

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    http.get<Customer[]>(baseUrl + 'api/Customer/list').subscribe(result => {
      this.customers = result;
      console.log('customers', this.customers);
    }, error => console.error(error));
  }

  ngOnInit() {
  }

}

interface Customer {
  id: number;
  name: string;
  email: string;
  phone: string;
  zip: string;
}
