import { Component, Inject } from "@angular/core";
import { ActivatedRoute, Router } from "@angular/router";
import { HttpClient } from "@angular/common/http";

@Component({
  selector: "survey",
  templateUrl: './survey.component.html',
  styleUrls: ['./survey.component.css']
})

export class SurveyComponent {
  survey: Survey;

  constructor(private activatedRoute: ActivatedRoute,
    private router: Router,
    private http: HttpClient,
    @Inject('BASE_URL') private baseUrl: string) {

    this.survey = <Survey>{};

    var id = this.activatedRoute.snapshot.params["id"];
    if (id) {
      var url = this.baseUrl + "api/survey/" + id;
      this.http.get<Survey>(url).subscribe(result => {
        this.survey = result;
      }, error => console.error(error))

    } else {
      this.router.navigate(["home"]);
    }
  }
}
