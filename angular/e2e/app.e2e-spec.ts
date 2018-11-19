import { EbusSoftTemplatePage } from './app.po';

describe('EbusSoft App', function() {
  let page: EbusSoftTemplatePage;

  beforeEach(() => {
    page = new EbusSoftTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
